import time

def run_microservice():
    f = open("prng-service.txt", "w")
    f.write("run")
    f.close()
    time.sleep(5)
    f = open("prng-service.txt", "r")
    randNum = f.read()
    f.close()
    return int(randNum)

if __name__ == "__main__":
    rng_number = run_microservice()
    print(rng_number)