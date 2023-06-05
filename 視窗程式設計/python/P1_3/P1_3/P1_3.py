from re import I
import tkinter as tk
from tkinter import ttk
import time

root = tk.Tk()
root.title('Progress Bar')
w=tk.Canvas(root,bg="white",width=640, height=400)
w.pack()
x=20
y=20
out_x=420
out_y=300
out_x2=220
out_y2=100
j=0
def run():
  progressBar['maximum'] = 100
  progressBar["value"] = 0
  tk.Label(root,text="      ", bg='green').place(x=320-140,y=350-30)

  for i in range(0,101,5):
      progressBar["value"]=i
      time.sleep(0.2)
      tk.Label(root,text=str(i),bg='green').place(x=320-140,y=350-30)
      progressBar.update()
      global j
      global out_x
      global out_y
      global out_x2 
      global out_y2
      if(j%5==0):
         w.create_oval(out_x, out_y, out_x2,out_y2,outline='black',fill='yellow')
         out_x=out_x-5
         out_y=out_y-5
         out_x2=out_x2+5
         out_y2=out_y2+5
      elif(j%5==1):
         w.create_oval(out_x, out_y, out_x2,out_y2,outline='black',fill='blue')
         out_x=out_x-5
         out_y=out_y-5
         out_x2=out_x2+5
         out_y2=out_y2+5
      elif(j%5==2):
         w.create_oval(out_x, out_y, out_x2,out_y2,outline='black',fill='purple')
         out_x=out_x-5
         out_y=out_y-5
         out_x2=out_x2+5
         out_y2=out_y2+5
      elif(j%5==3):
         w.create_oval(out_x, out_y, out_x2,out_y2,outline='black',fill='red')
         out_x=out_x-5
         out_y=out_y-5
         out_x2=out_x2+5
         out_y2=out_y2+5
      elif(j%5==4):
         w.create_oval(out_x, out_y, out_x2,out_y2,outline='black',fill='green')
         out_x=out_x-5
         out_y=out_y-5
         out_x2=out_x2+5
         out_y2=out_y2+5
      j=j+1



button1 = tk.Button(root, bg='lime', text="Run Progress Bar",command=run)
button1.place(x=260,y=30)

progressBar = ttk.Progressbar(root, orient="horizontal", length=300,mode="determinate")
#determinate (確定，預設)， indeterminant (不確定)
progressBar.place(x=320-140, y=350)

root.mainloop()
