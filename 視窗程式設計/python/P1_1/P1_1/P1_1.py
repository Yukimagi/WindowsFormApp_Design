import tkinter as tk
#�ظm�e��
root = tk.Tk()
root.title('my window')
#�ظm�@�ӵe��
w = tk.Canvas(root, bd=10, bg='blue', cursor='plus', height=330, width=400 )
w.pack()
 
#�H���������

w.create_rectangle(50,50,110,110,outline='black')
w.create_oval(50,50,110,110,outline='black')
w.create_line(100,150,200,150,width=10,fill='black')
w.create_arc(310,310, 190, 190, start=30,extent=300,fill='yellow',width=5) 
w.create_oval(250,250,250,250,outline='red',width=5)

#��s�e��
root.mainloop()
