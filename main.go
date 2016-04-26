package main

import (
	"flag"
	"fmt"
	"nth-digit-factorial/models"
	"runtime/debug"
	"strconv"
	"unsafe"
)

func main() {
	// define flags

	var pi = flag.Bool("pi", false, "Generate pi")
	var euler = flag.Bool("e", false, "Generate e")
	var floatBig = flag.Bool("f", false, "Surveying float in 32bit and 64bit and its failure ratio")
	var semaphore = flag.Int("v", 1, "flag for cases")

	flag.Parse()

	debug.FreeOSMemory()

	if *pi == true {
		models.ExecutePi(*semaphore)
	}

	if *euler == true {
		models.ExecuteE(*semaphore)
	}

	if *floatBig == true {
		switch *semaphore {
		case 1:
			a := float32(0.1)
			fmt.Printf("float32(0.1): %032s\n", strconv.FormatUint((uint64)(*(*uint32)(unsafe.Pointer(&a))), 2))
			b := float64(0.1)
			fmt.Printf("float64(0.1): %064s\n\n", strconv.FormatUint((*(*uint64)(unsafe.Pointer(&b))), 2))

			a = 0.2
			fmt.Printf("float32(0.2): %032s\n", strconv.FormatUint((uint64)(*(*uint32)(unsafe.Pointer(&a))), 2))
			b = 0.2
			fmt.Printf("float64(0.2): %064s\n\n", strconv.FormatUint((*(*uint64)(unsafe.Pointer(&b))), 2))

			a = 0.3
			fmt.Printf("float32(0.3): %032s\n", strconv.FormatUint((uint64)(*(*uint32)(unsafe.Pointer(&a))), 2))
			b = 0.3
			fmt.Printf("float64(0.3): %064s\n", strconv.FormatUint((*(*uint64)(unsafe.Pointer(&b))), 2))

		case 2:
			fmt.Println("After 3000 loops of 0.8 + 0.1 - 0.9")
			var xxx float32 = 0
			for i := 0; i < 3000; i++ {
				xxx += float32(float64(float32(0.8)+float32(0.1)) - float64(0.9))
			}

			fmt.Printf("This is the result: %.30f\n", xxx)
		}
	}
}
