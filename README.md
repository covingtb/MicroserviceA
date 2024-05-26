______________________________________________________________________________________________________________________________________
              Communication Contract
______________________________________________________________________________________________________________________________________

A. In order to request a new pseudo-random number from the microservice, one only needs to write to the .txt file the string "run" and the 
    microservice will generate a number for the user to use from 1-100. The only modules needed are the time  and the random modules.

    Example of a call:

    f = open("prng-service.txt", "w")
    f.write("run")

______________________________________________________________________________________________________________________________________

B. In order to receive data from the microservice, simply open the .txt file and read the first line that the service wrote.

    Example:

    f = open("prng-service.txt", "r")
    randNum = f.read()

______________________________________________________________________________________________________________________________________

![Blank diagram](https://github.com/covingtb/MicroserviceA/assets/130528772/f0ad0823-bd6a-4750-80be-63c672c7c8e8)

