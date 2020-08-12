
from time import *
from datetime import *
from dateutil import*
from pytz import*

Portland_tz = tz.gettz("PDT")
NY_tz = tz.gettz("EST")
London_tz = tz.gettz("Europe/London")


pdx = ("The current time in Portland, is")
ny = ("The current time in New York, is")
lon = ("The current time in London, is")

openTime = time(9,0,0)
closeTime = time(15,0,0)

now = datetime.now(tz=Portland_tz)
now1 = datetime.now(tz=NY_tz)
now2 = datetime.now(tz=London_tz)


def storeHoursP():
    if Portland_tz >= openTime and Portland_tz <= closeTime:
        print(pdx, now, 'Store opened')
    else:
        print(pdx, now, 'Store closed')

def storeHoursN():
    if NY_tz >= openTime and NY_tz <= closeTime:
        print(ny, now1, 'Store opened')
    else:
        print(ny, now1, 'Store closed')

def storeousrL():
    if London_tz >= openTime and London_tz <= closeTime:
        print(lon, now2, 'Store opened')
    else:
        print(lon, now2, 'Store closed')


Portland_tz = tz.gettz("PDT")
print(storeHoursP())

NY_tz = tz.gettz("EST")
print(storeHoursN())

London_tz = tz.gettz("Europe/London")
print(storeHoursL())

