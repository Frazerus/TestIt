
from selenium import webdriver
import pathlib
from selenium.webdriver.edge.service import Service
from selenium.webdriver.edge.options import Options

shouldUseLocalEdge = False

path = pathlib.Path(__file__).parent.resolve().__str__()

options = Options()
options.binary_location = path + r"\edge_v121\msedge.exe"


if shouldUseLocalEdge:
    driver = webdriver.Edge()
else:
    driver = webdriver.Edge(options=options)

driver.get('https://bing.com')

import time
time.sleep(5)

driver.close()
driver.quit()