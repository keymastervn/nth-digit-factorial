all:
	echo "Khao sat sai so floating point"
	echo "Python >>>"
	python fp.py
	echo "Ruby >>>"
	ruby fp.rb
	echo "Javascript/Nodejs >>>"
	node fp.js
	echo "Java >>>"
	javac -cp . fp.java && java FloatingPoint
	echo "Golang >>>"
	go run fp.go
	echo "SQLITE3 >>>"
	sqlite3 <<< 'select (1.0 + 2.0/3.0 - 2.0/3.0);'
	echo "PERL >>>"
	perl -E "say 1.0 + 2.0/3.0 - 2.0/3.0"

install:
	sudo add-apt-repository ppa:fkrull/deadsnakes
	sudo apt-get update 
	sudo apt-get install ruby-full
	sudo apt-get install python2.7
	sudo apt-get install nodejs
	sudo apt-get install sqlite3
	echo "For golang please access: https://golang.org/dl/"
	echo "For java please access: https://java.com/en/download/"
	echo "For perl please access: https://www.perl.org/get.html"

