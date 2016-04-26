# nth-fraction-digit intro
N-th digit of famous numbers, an implementation in normal and in BBP formula, euler number's fraction extractor and investigate Float type aberrance

# Chapter 1
Chapter 1 is implementations of Float while calculating `1.0 + 2.0/3.0 - 2.0/3.0` in many languages such as python, ruby, java, golang, sqlite, perl ...

1. To install prerequisite for ubuntu
`$ cd ./chapter1 && make install`
2. To run demo
`$ make`

# Chapter 2
_XN_ is a package writeen in Csharp, which demo the effects of calculating n * x where n is an int and x is a float

Recommend: For mac user, install visual studio/xamarin to be able to compile and build C#. Window user can natively compile and build easy in VS.

# N-th fraction digit

Source code is in golang. There's a binary file compiled for mac can be used to run. Assume that you know how to install go.
1. To build nth-fraction-digit
`go build`
Then will come a nth-fraction-digit

2. To investigate big float
Bit code of float32 and float64 in golang
`$ ./nth-fraction-digit -f -v=1`
The result of 3000 loops of 0.8 + 0.1 - 0.9
`$ ./nth-fraction-digit -f -v=2`

3. To investigate pi
Generate pi by using Leibniz formula
`$ ./nth-fraction-digit -pi -v=1`
Generate 30th number of pi using BBP
`$ ./nth-fraction-digit -pi -v=2`

4. To investigate euler number
Generate e in basic formula 1/0! + 1/1! + 1/2! + ... + 1/n!
`$ ./nth-fraction-digit -e -v=1`
Generate 9000 fraction number of e using Xavier Formula
`$ ./nth-fraction-digit -e -v=2`

