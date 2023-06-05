import tkinter as tk
from tkinter import ttk
import time

root = tk.Tk()
w=tk.Canvas(root,bg="green",width=600, height=600)
w.pack()


while(True):
    for i in range(3):
      w.create_oval(200, 200, 400, 400,fill="yellow",outline='green')
      w.create_arc(200, 200, 400, 400, start=330,extent=60,fill="green",outline='green')
      w.update()
      time.sleep(0.5)
      
      w.create_oval(200, 200, 400, 400,fill="yellow",outline='green')
      w.create_arc(200, 200, 400, 400, start=359,extent=1,fill="green",outline='green')
      w.update()
      time.sleep(0.5)
    for i in range(3):
      w.create_oval(200, 200, 400, 400,fill="yellow",outline='green')
      w.create_arc(200, 200, 400, 400, start=240,extent=60,fill="green",outline='green')
      w.update()
      time.sleep(0.5)
      
      w.create_oval(200, 200, 400, 400,fill="yellow",outline='green')
      w.create_arc(200, 200, 400, 400, start=269,extent=1,fill="green",outline='green')
      w.update()
      time.sleep(0.5)
    for i in range(3):
      w.create_oval(200, 200, 400, 400,fill="yellow",outline='green')
      w.create_arc(200, 200, 400, 400, start=150,extent=60,fill="green",outline='green')
      w.update()
      time.sleep(0.5)
      
      w.create_oval(200, 200, 400, 400,fill="yellow",outline='green')
      w.create_arc(200, 200, 400, 400, start=179,extent=1,fill="green",outline='green')
      w.update()
      time.sleep(0.5)
    for i in range(3):
      w.create_oval(200, 200, 400, 400,fill="yellow",outline='green')
      w.create_arc(200, 200, 400, 400, start=60,extent=60,fill="green",outline='green')
      w.update()
      time.sleep(0.5)
      
      w.create_oval(200, 200, 400, 400,fill="yellow",outline='green')
      w.create_arc(200, 200, 400, 400, start=89,extent=1,fill="green",outline='green')
      w.update()
      time.sleep(0.5)



root.mainloop()

    
