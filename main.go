package main

import (
	"flag"
	"nth-digit-factorial/models"
	"runtime/debug"
)

func main() {
	// define flags

	var pi = flag.String("pi", "", "Export MW_ITEMS to the given file")
	var euler = flag.String("e", "", "Import MW_ITEMS from the given file")

	flag.Parse()

	debug.FreeOSMemory()

	if *pi != "" {
		models.ExecutePi()
	}

	if *euler != "" {
		models.ExecuteE()
	}
}
