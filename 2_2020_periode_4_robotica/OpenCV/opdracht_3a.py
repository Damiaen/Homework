import numpy as np
import cv2
import math

def opdracht_3a():
    img = cv2.imread('./images/tek2.png')
    hsv = cv2.cvtColor(img, cv2.COLOR_BGR2HSV)

    # define range of blue color in HSV
    lower_blue = np.array([110,50,50])
    upper_blue = np.array([130,255,255])
    lower_green = np.array([50,50,50])
    upper_green = np.array([70,255,255])
    
    # for red we need to define multiple, since hsv wraps around
    low_lower_red = np.array([0,50,50])
    low_upper_red = np.array([10,255,255])
    up_lower_red = np.array([170,50,50])
    up_upper_red = np.array([180,255,255])

    
    mask_blue = cv2.inRange(hsv, lower_blue, upper_blue)
    mask_green = cv2.inRange(hsv, lower_green, upper_green)

    mask_red_lower = cv2.inRange(hsv, low_lower_red, low_upper_red)
    mask_red_up = cv2.inRange(hsv, up_lower_red, up_upper_red)

    mask = mask_red_lower | mask_red_up

    res_blue = cv2.bitwise_and(img, img, mask= mask_blue)
    res_red = cv2.bitwise_and(img, img, mask= mask)
    res_green = cv2.bitwise_and(img, img, mask= mask_green)
    
    # cv2.imshow('logo', img)
    # cv2.imshow('blue', res_blue)
    cv2.imshow('red', res_red)
    # cv2.imshow('green', res_green)

opdracht_3a()

k = cv2.waitKey(0)
print(k)
cv2.destroyAllWindows()
