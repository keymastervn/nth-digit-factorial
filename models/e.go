package models

import "fmt"

type EulerNumber struct {
}

// declare factorial
func factorial(number int64) int64 {
	if number == 1 || number == 0 {
		return 1
	}
	return number * factorial(number-1)
}

// e = 1/0! + 1/1! + 1/2! + ... + 1/n!
func NormalGenerate(n int64) {

	var euler float64 = 0
	var term float64 = 0
	var i int64 = 0
	for ; i <= n; i++ {
		// calc term
		term = 1 / float64(factorial(i))
		// because 2^64 has only 29 character to be shown
		fmt.Printf("[%d]Term to be summed up: %.29f\n", i, term)
		// sum term to E
		euler = euler + term
	}
	fmt.Printf("This is euler in normal formula in %d try: %.29f \n", n, euler)
}

// Xavier Gourdon (Jul 1999) to compute 9000 decimal digits of e
// refs: http://numbers.computation.free.fr/Constants/TinyPrograms/tinycodes.html#tth_sEc2
func XavierGenerate(n int64) {
	var poop int64
	poop = n + 9
	var arrayN [9009]int64
	var x int64 = 0
	var i int64 = 2
	arrayN[0] = 0
	arrayN[1] = 2

	for ; i < poop; i = i + 1 {
		arrayN[i] = 1
	}

	// reset i
	i = 0

	for ; poop > 9; poop = poop - 1 {
		for i = poop - 1; i > 0; i = i - 1 {
			arrayN[i] = x % i
			x = 10*arrayN[i-1] + x/i
		}

		fmt.Printf("%d", x)
	}
}

func ExecuteE(flag int) {
	switch flag {
	case 1:
		NormalGenerate(60)
	case 2:
		XavierGenerate(9000)
	}
}
