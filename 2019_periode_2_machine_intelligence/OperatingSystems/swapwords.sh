#!/bin/bash

showMissingParams()
{
   echo ""
   echo "parameters are missing"
   echo "Usage: -a select word -b change to -c filename"
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
   showMissingParams
fi

# Begin script in case all parameters are correct
echo "$parameterA"
echo "$parameterB"
echo "$parameterC"

echo "Beginning swapping of words"

sed "s/${parameterA}/${parameterB}/g" $parameterC

echo "Swapping of words completed"
