import tkinter as tk
from PIL import Image, ImageTk 

#建置容器
root = tk.Tk()
root.title('image window')
img = Image.open('pic.png')
img1 = ImageTk.PhotoImage(img)
#建置一個畫布
w = tk.Canvas(root, width=img.size[0], height=img.size[1])
w.pack()
#寫在下面
w.create_image(0,0, anchor=tk.NW, image=img1)

#刷新畫面
root.mainloop()
