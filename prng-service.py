import time, random

while True:
    time.sleep(1)
    f = open("prng-service.txt", "r+")
    if f.readline() == "run":
        time.sleep(1)
        random.seed()
        randNum = str(random.randint(1, 100))
        f.seek(0)
        f.truncate()
        f.write(randNum)
    f.close()