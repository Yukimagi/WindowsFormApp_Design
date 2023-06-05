from enum import Flag
from pickle import FALSE
from re import I
import tkinter as tk
import time
#建置容器
root = tk.Tk()
root.title('my window')
h=400
w=400
r=60
y=h/2
x=w/2
flag=0
i=0
test=True
#建置一個畫布
c = tk.Canvas(root,bg='blue', width=w, height=h)
c.pack()#pack()打包
#------------
def b1():
    global flag
    flag=flag+1
    while flag%2>0:
        pacman()

def pacman():
    c.create_oval(x-r, y-r, x+r, y+r, fill="#FF0000")
    time.sleep(0.5)
    c.update()
    c.create_oval(x-r, y-r, x+r, y+r, fill="black")
    time.sleep(0.5)
    c.update()

pixel = tk.PhotoImage(width='20', height='20')
button1=tk.Button(root, text="GO", fg="black", bg="gray", command=b1)
button1.config(image=pixel,compound="c")#需加compound="c"才會有文字
button1.pack()
button1.place(x=250,y=4)
   

#刷新畫面
root.mainloop()
