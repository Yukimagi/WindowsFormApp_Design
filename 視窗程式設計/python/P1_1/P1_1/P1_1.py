import tkinter as tk
#建置容器
root = tk.Tk()
root.title('my window')
#建置一個畫布
w = tk.Canvas(root, bd=10, bg='blue', cursor='plus', height=330, width=400 )
w.pack()
 
#以像素為單位

w.create_rectangle(50,50,110,110,outline='black')
w.create_oval(50,50,110,110,outline='black')
w.create_line(100,150,200,150,width=10,fill='black')
w.create_arc(310,310, 190, 190, start=30,extent=300,fill='yellow',width=5) 
w.create_oval(250,250,250,250,outline='red',width=5)

#刷新畫面
root.mainloop()
