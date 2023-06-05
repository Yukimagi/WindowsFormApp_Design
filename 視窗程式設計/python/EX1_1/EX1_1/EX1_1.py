import tkinter as tk 
#建置容器
root = tk.Tk() 
root.title('window for rectangle') 
#建置一個畫布
w = tk.Canvas(root, width=400, height=400) 
w.pack()#pack()打包
#寫在下面

w.create_rectangle(10, 10, 100, 100,outline='blue')
w.create_oval(10, 10, 100, 100,outline='red')
w.create_arc(10, 10, 100, 100) 

w.create_rectangle(110, 10, 200, 100,outline='blue')
w.create_oval(110, 10, 200, 100,outline='red')
w.create_arc(110, 10, 200, 100, extent=45) 

w.create_rectangle(210, 10, 300, 100,outline='blue')
w.create_oval(210, 10, 300, 100,outline='red',dash=(4, 3))#dash 虛線
w.create_arc(210, 10, 300, 100, extent=180)

w.create_rectangle(10, 110, 100, 210,outline='blue')
w.create_oval(10, 110, 100, 210,outline='red',dash=(4, 3))#dash 虛線
w.create_arc(10, 110, 100, 210, style=tk.ARC, width=3) 

w.create_rectangle(110, 110, 200, 210,outline='blue')
w.create_oval(110, 110, 200, 210,outline='red',dash=(4, 3))#dash 虛線
w.create_arc(110, 110, 200, 210, style=tk.PIESLICE) 

w.create_rectangle(210, 110, 300, 210,outline='blue')
w.create_oval(210, 110, 300, 210,outline='red',dash=(4, 3))#dash 虛線
w.create_arc(210, 110, 300, 210, style=tk.CHORD)

##刷新畫面
root.mainloop()
