import xml.etree.cElementTree as ET

root = ET.Element("Root")
doc = ET.SubElement(root, "ObjectInfo")

ET.SubElement(doc, "Shape", name="shape").text = "SQUARE"
ET.SubElement(doc, "Color", name="color").text = "BLUE"

tree = ET.ElementTree(root)
tree.write("results.xml")

