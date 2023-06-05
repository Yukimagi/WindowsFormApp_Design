import tkinter as tk 
#建置容器
root = tk.Tk() 
root.title('window for rectangle') 
#建置一個畫布
w = tk.Canvas(root, width=400, height=400) 
w.pack()#pack()打包
#寫在下面

w.create_rectangle(350,350,100,100) 
w.create_rectangle(350,350,200,150, outline='red') 
w.create_rectangle(350,350,200,200, outline='blue')
w.create_oval(350,350,200,200,outline='black')

##刷新畫面
root.mainloop()
