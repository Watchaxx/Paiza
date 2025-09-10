# 実行時間 20ms
import sys

r = sys.stdin.readline
dx = 1
dy = 0
n = int(input())

for _ in [0] * n:
    x = r()[0]

    if (dx == 0 and dy == -1 and x == "/") or (dx == 0 and dy == 1 and x == "\\"):
        dx = 1
        dy = 0
    elif (dx == 0 and dy == 1 and x == "/") or (dx == 0 and dy == -1 and x == "\\"):
        dx = -1
        dy = 0
    elif (dx == 1 and dy == 0 and x == "/") or (dx == -1 and dy == 0 and x == "\\"):
        dx = 0
        dy = -1
    elif (dx == -1 and dy == 0 and x == "/") or (dx == 1 and dy == 0 and x == "\\"):
        dx = 0
        dy = 1
    print(dx, dy)
