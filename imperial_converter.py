# imperial_converter
# 1 foot = 0.0003048km, 0.3048m, 30.48cm, 304.8 mm
# converting 1 inch to km involves dividing it by 39370
# 1 inch = 0.0254m, 2.54 cm, 25.4 mm

km = 0.0003048
m = 0.3048
cm = 30.48
mm = 304.8

km1 = 0.0000254
m1 = 0.0254
cm1 = 2.54
mm1 = 25.4

# user input their height in feet and inches
height = int(input("Whats your height in feet:"))
height1 = int(input("What's your height in inches: "))

# expressing the height in km, m, cm, mm
height_km = (height * km) + (height1 * km1)
print("Height in kilometres: {}".format(height_km))

height_m = (height * m) + (height1 * m1)
print("Height in metres: {}".format(height_m))

height_cm = (height * cm) + (height1 * cm1)
print("Height in centimetres: {}".format(height_cm))

height_mm = (height * mm) + (height1 * mm1)
print("Height in millimetres: {}".format(height_mm))
