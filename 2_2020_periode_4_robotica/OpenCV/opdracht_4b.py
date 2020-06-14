import cv2
import numpy as np

def opdracht_4b():
    img = cv2.imread("./images/bouten_moeren2.jpg")
    imgray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
    grayBlur = cv2.GaussianBlur(imgray, (5, 5), 0)

    ret, th = cv2.threshold(grayBlur, 180, 255, cv2.THRESH_BINARY_INV)
    contours, hierarchy = cv2.findContours(th, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)

    hierarchy = hierarchy[0]
    for cnr in range(len(contours)):
        cnt = contours[cnr]
        area = cv2.contourArea(cnt)
        if area < 500:
            continue
        perimeter = cv2.arcLength(cnt, True)
        factor = 4 * np.pi * area / perimeter ** 2
        holes = 0
        child = hierarchy[cnr][2]
        while child >= 0:
            holes += cv2.contourArea(contours[child])
            child = hierarchy[child][0]

        if holes > 200:
            cv2.drawContours(img, [cnt], -1, (255, 0, 0), 3)
            print("Color: Blue Shape: Nut  Factor: ", factor," Holes: ", holes)
        elif factor > 0.8 and factor < 0.85 :
            cv2.drawContours(img, [cnt], -1, (0, 255, 0), 3)
            print("Color: Green Shape: Standing Bolt  Factor: ", factor," Holes: ", holes)
        elif factor < 0.5:
            cv2.drawContours(img, [cnt], -1, (0, 255, 255), 3)
            print("Color: Yellow Shape: Standing Nut  Factor: ", factor," Holes: ", holes)
        elif factor < 0.75 and factor > 0.65:
            cv2.drawContours(img, [cnt], -1,(0, 0, 255), 3)
            print("Color: Red Shape: Bolt  Factor: ", factor," Holes: ", holes)
        else:
            print("Unsupported shape at: Factor: ", factor," Holes: ", holes)


    cv2.imshow('frame', img)
    
opdracht_4b()

k = cv2.waitKey(0)
print(k)
cv2.destroyAllWindows()
