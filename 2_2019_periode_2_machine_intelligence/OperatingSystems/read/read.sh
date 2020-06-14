#!/bin/bash
file="linux.txt"
while read line; do
echo $line
done < $file
