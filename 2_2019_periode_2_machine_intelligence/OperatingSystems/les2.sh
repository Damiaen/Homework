#!/bin/sh

#Start opdracht 1
#
# echo " Ik ($USER) wil graag een Linux Nerd worden "
# echo 'Ik ($USER) wil graag een Linux Nerd worden'
# echo Ik ($USER) wil graag een Linux Nerd worden
#
# echo " onderzoek naar echo "
# echo -e " aap\bnoot "
# echo -e " aap\cnoot "
# echo -e " aap\nnoot "
# echo -e " aap\tnoot "
# echo -e " aap\\noot "
#Als je de -e weglaat dan gaat et niet goed met de /
#
# x=2; y=5; echo De som = x+y
# echo De som = $(x+y)
# echo " De som = $(x+y) "
# echo " De som = $((x+y)) "
#
# echo "($x+$y)/2"
# echo "($x+$y)/2" | bc
# echo "($x+6.7)/2" | bc
#
# echo "*"
# echo *
# echo *.txt
#
# echo aap || echo noot && echo mies
# echo $USER && echo $HOME
# echo pwd && echo $USER waar ben ik
#
#Eind opdracht 1

#Start opdracht 2
#grep "x" ./les2.sh

date
date +%D
date + %D
echo "datum: date"
echo `date` echo "datum: `date +%D`"

datum='26/02/06'
echo $datum
datum ='26/02/09' 
echo $datum
datum= '26/02/09'
echo $datum
datum='date'
echo $datum
datum= 'date'
echo $datum

$datum

datum=`date +%D`
datum=date +%D
echo "datum: $datum"
