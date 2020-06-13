#!/bin/bash
if [ $1 -gt $2 ]
then
   echo $1 is groter dan $2
   pwd
fi

if [ $1 != $2 ]
then
   echo $1 is niet gelijk aan $2
   pwd
fi

if [ $1 < $2 ]
then
   echo $2 is groter dan $1
   pwd
fi

if [ $1 <= $2 ]
then
   echo $2 is groter of gelijk aan $1
   pwd
fi

if [ $1 > $2 ]
then
   echo $1 is groter dan $2
   pwd
fi

if [ $1 >= $2 ]
then
   echo $1 is groter of gelijk aan $2
   pwd
fi
