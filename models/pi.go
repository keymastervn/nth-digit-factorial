package models

import (
	"fmt"
	"github.com/akalin/aks-go/aks"
	"log"
	"math"
	"math/big"
	"os"
)

func isOdd(number int) bool {
	return number%2 != 0
}

// 1 -1/3 +1/5 -1/7 + 1/9 - ... = pi/4
func LeibnizGenerate(n int) {
	var pi float64 = 0
	var sign bool = true //the +- operator marker

	for i := 1; i <= n; i++ {
		j := float64(i)
		if isOdd(i) {
			if sign {
				pi = pi + 4/j
			} else {
				pi = pi - 4/j
			}
			sign = !sign
		}
	}
	fmt.Println("This is pi in Leibniz formula in 65355 try: ", pi)
}

func mulMod(a int64, b int64, m int64) int64 {
	return (a * b) % m
}

func modInverse(a int64, n int64) int64 {

	i := n
	var v int64 = 0
	var d int64 = 1
	for a > 0 {
		t := i / a
		x := a

		a = i % x
		i = x
		x = d
		d = v - t*x
		v = x
	}
	v = v % n

	if v < 0 {
		v = (v + n) % n
	}

	return v
}

func nextPrime(n int64) int64 {
	if n < 2 {
		return 2
	}

	for i := n + 1; ; i++ {
		if isPrime(i) {
			return i
		}
	}

	return 0
}

func isPrime(i int64) bool {
	if i == 2 || i == 3 {
		return true
	}

	if i%2 == 0 || i%3 == 0 || i < 2 {
		return false
	}

	sqrt := int64(math.Sqrt(float64(i)) + 1)
	var j int64 = 6
	for ; j <= sqrt; j += 6 {
		if i%(j-1) == 0 {
			return false
		} else if i%(j+1) == 0 {
			return false
		}
	}
	return true
}

// isPrimeAKS under AKS implementation
func isPrimeAKS(i int64) bool {
	cv := big.NewInt(i)
	n := *cv
	// Set n to the number you wish to test.
	var jobs int
	// Set jobs to the number of goroutines to use when testing n.
	r := aks.CalculateAKSModulus(&n)
	M := aks.CalculateAKSUpperBound(&n, r)
	logger := log.New(os.Stderr, "", 0)
	a := aks.GetAKSWitness(&n, r, &big.Int{}, M, jobs, logger)
	if a != nil {
		// n is composite with AKS witness a
		return false
	} else {
		// n is prime
		return true
	}
}

func powMod(a int64, b int64, m int64) int64 {
	var tempo int64

	if b == 0 {
		tempo = 1
	} else if b == 1 {
		tempo = a
	} else {
		temp := powMod(a, b/2, m)
		if b%2 == 0 {
			tempo = (temp * temp) % m
		} else {
			tempo = ((temp * temp) % m) * a % m
		}
	}
	return tempo
}

func BBP(n int64) {
	var av, a, vmax, num, den, k, kq, kq2, t, v, s, i int64
	var sum, N float64

	N = float64((n + 20)) * math.Log(10) / math.Log(2)
	sum = 0

	for a = 3; a <= int64((2 * N)); a = nextPrime(a) {
		vmax = int64(math.Log(2*N) / math.Log(float64(a)))

		av = 1
		for i = 0; i < vmax; i++ {
			av = av * a
		}

		s = 0
		num = 1
		den = 1
		v = 0
		kq = 1
		kq2 = 1

		for k = 1; k <= int64(N); k++ {
			t = k
			if kq >= a {

				for t%a == 0 {
					t = t / a
					v--
				}
				kq = 0
			}
			// fmt.Println("t:", t)
			// fmt.Println("v:", v)
			// fmt.Println("")

			kq++
			num = mulMod(num, t, av)

			t = 2*k - 1
			if kq2 >= a {
				if kq2 == a {
					for t%a == 0 {
						t = t / a
						v++
					}
				}
				kq2 -= a
			}
			// fmt.Println("kq2:", kq2)

			den = mulMod(den, t, av)
			kq2 += 2

			if v > 0 {
				t = modInverse(den, av)
				t = mulMod(t, num, av)
				t = mulMod(t, k, av)

				for i = v; i < vmax; i++ {
					t = mulMod(t, a, av)
				}

				s = s + t
				// fmt.Println("s:", s)
				if s >= av {
					s = s - av
				}
			}
		}
		t = powMod(10, n-1, av)
		// fmt.Println("t:", t)
		s = mulMod(s, t, av)
		// fmt.Println("s:", s)

		sum = (sum + float64(s)/float64(av))
		sum = sum - math.Floor(sum)
		// fmt.Println("sum:", sum)
	}

	fmt.Printf("This is %dth digit pi in BBP formula: %d \n", n, int64(sum*10)) // 9 decimal
}

func ExecutePi(flag int) {
	switch flag {
	case 1:
		LeibnizGenerate(65355)
	case 2:
		BBP(30)
	}
}
