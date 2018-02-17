import numpy as np
import cv2
import xml.etree.cElementTree as ET

#activate opencv-env
# ====================== Step 1 ======================
#              Load the image and resize
img = cv2.imread("C:/Workspaces/Products/InterCapstone/Capstone2018/Capstone2018/Content/img/box.jpeg")
img = cv2.resize(img, (400,400))
#cv2.imshow("Original Picture", img)

# ====================== Step 2 ======================
#              Turn Image to Grayscale
gray = cv2.cvtColor(img, cv2.COLOR_RGB2GRAY)
#cv2.imshow("Grayscale of image", gray)

# ====================== Step 3 ======================
#                     Filter image
#                     Gaussian Blur
blur_gray = cv2.GaussianBlur(gray, (5,5), 0)
#cv2.imshow("Blurred image", blur_gray)

# ====================== Step 4 ======================
#                  Appliying threshold
#                     Otsu threshold
_, otsu = cv2.threshold(blur_gray, 0, 255, cv2.THRESH_BINARY+cv2.THRESH_OTSU)
#cv2.imshow("Threshold image", otsu)

# ====================== Step 5 ======================
#                 Try to find contours
_, contours, _ = cv2.findContours(otsu, 1, 2)
#cv2.drawContours(img, contours, -1, (0,255,0), 1)
#cv2.imshow("Image with contours", img)

# ====================== Step 6 ======================
#                   Define the shape
for cnt in contours:
    approx = cv2.approxPolyDP(cnt,0.01*cv2.arcLength(cnt,True),True)

    print(len(approx))

    if(len(approx) == 4):
        print("SQUARE!")
        # ====================== Create XML ======================
        root = ET.Element("Object")

        ET.SubElement(root, "Shape", name="shape").text = "SQUARE"
        #ET.SubElement(doc, "Color", name="color").text = "BLUE"

        tree = ET.ElementTree(root)
        tree.write("results.xml")
        # ============================================
        print(cnt)
        cv2.drawContours(img,[cnt], 0, (0,255,0), -1)

#cv2.imshow("Image with contours but with noise", img)



# ======================== END ========================

cv2.waitKey(0)
cv2.destroyAllWindows()
