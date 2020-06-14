#!/bin/sh

for i in $(seq 1 8)
do
	for j in $(seq 1 8)
	do
		S=$(((i+j)%2))
		if [ $S -eq 0 ]
		then
			echo -e -n "\033[47m " # white
		else
			echo -e -n "\033[40m " # black
		fi
	done
	echo -e -n "\033[40m" # black, ensure it exists normally
	echo "" # new line
done
