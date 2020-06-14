#!/bin/bash

showMising()
{
   echo ""
   echo "parameters are missing"
   echo "Usage: -a 1 -b 1 -c 3"
   exit 1 # Exit script after this
}

while getopts "a:b:c:" opt
do
   case "$opt" in
      a ) parameterA="$OPTARG" ;;
      b ) parameterB="$OPTARG" ;;
      c ) parameterC="$OPTARG" ;;
   esac
done

# Print error if some are missing
if [ -z "$parameterA" ] || [ -z "$parameterB" ] || [ -z "$parameterC" ]
then
   showMissing
fi

# Begin script in case all parameters are correct
echo "$parameterA"
echo "$parameterB"
echo "$parameterC"

if [ "$parameterA" == "$parameterB" ]
then
    echo "$parameterA is the same as $parameterB"
fi
