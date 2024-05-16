import threading
import time
def delayed():
    print("print after 5 seconds!")
thread = threading.Timer(5, delayed)
thread.start()