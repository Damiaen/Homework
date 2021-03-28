import cv2
import numpy as np
import array

def calculateAmount(number, dice, originalimage, originalx, originaly):
    ret_count, th_count = cv2.threshold(dice, 230, 255, cv2.THRESH_BINARY)
    contours, hierarchy = cv2.findContours(th_count, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)
        
    count = 0
    for cnr in range(len(contours)):
        
        cnt = contours[cnr]
        perimeter = cv2.arcLength(cnt, True)
        area = cv2.contourArea(cnt)
        
        if perimeter == 0 or area == 0:
            continue
        
        factor = 4 * np.pi * area / perimeter ** 2
        
        if factor > 0.5 and area > 10:
            cv2.drawContours(dice, [cnt], -1, (0, 255, 255), 3)
            count += 1
            
    cv2.imshow('Dice: %s' % number, dice)
    print('Found %s eyes on dice %s' % (count, number))
    cv2.putText(originalimage, '%s' % count, (originalx, originaly), cv2.FONT_HERSHEY_SIMPLEX, 1, (255, 255, 255), 2)
    return count

def opdracht_5():
    img = cv2.imread("./images/dobbelstenen.png")
    imgray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
    grayBlur = cv2.GaussianBlur(imgray, (3, 3), 0)

    ret, th = cv2.threshold(grayBlur, 5, 255, cv2.THRESH_BINARY_INV)
    contours, hierarchy = cv2.findContours(th, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)


    # Put contour around each dice
    #for cnt in contours:
    #    area = cv2.contourArea(cnt)
    #    if (area < 10000):
    #        cv2.drawContours(img, [cnt], -1, (0, 255, 255), 3)

    # Store which dice we are on
    number = 0
    a = []
    for cnr in range(len(contours)):
        if (cnr == 0): # Skip first index, since this is the full image
            continue
        
        number += 1
        x, y, w, h = cv2.boundingRect(contours[cnr])
        die = grayBlur[y:y + h, x:x + w]
        test = calculateAmount(number, die, img, x, y)
        a.append(test)

    print(sorted(a))
    cv2.putText(img, '%s' % sorted(a), (200, 200), cv2.FONT_HERSHEY_SIMPLEX, 1, (255, 255, 255), 2)

    cv2.imshow('Total', img)
    
opdracht_5()

k = cv2.waitKey(0)
print(k)
cv2.destroyAllWindows()
