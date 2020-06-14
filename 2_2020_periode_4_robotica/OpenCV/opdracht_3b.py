import cv2
import numpy as np


def opdracht_3b():
    img = cv2.imread("./images/tek1.png")

    imgray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
    ret, thresh = cv2.threshold(imgray, 20, 255, 0)
    contours, hierarchy = cv2.findContours(thresh, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)

    cnt = contours[13]
    M = cv2.moments(cnt)

    cx = int(M['m10']/M['m00'])
    cy = int(M['m01']/M['m00'])
    
    cv2.drawContours(img, contours, 13 , (50, 255, 255), 3)
    cv2.circle(img, (cx, cy), 3, (50, 255, 255), 5)

    cv2.imshow('imgray', imgray)
    cv2.imshow('final', img)
    

opdracht_3b()

k = cv2.waitKey(0)
print(k)
cv2.destroyAllWindows()
