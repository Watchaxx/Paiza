# 実行時間 10ms
input()
p1 = list(map(float, input().split()))
p2 = list(map(float, input().split()))
print(f"{p2[1] - p1[1]} {( p2[0] - p1[0] ) * -1} {( p2[0] - p1[0] ) * p1[1] - ( p2[1] - p1[1] ) * p1[0]}")
