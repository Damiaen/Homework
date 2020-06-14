#!/bin/sh

date +'%m/%d/%y'
date +'%r'

date +'%A %B %r'

now=$(date)
echo "$now"

fileName=$(date +'%r')

touch $fileName '.txt'

touch test.txt
date > test.txt
