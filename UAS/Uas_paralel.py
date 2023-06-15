import os
import tkinter as tk
from tkinter import filedialog
from tkinter import messagebox
from tkinter.ttk import Progressbar
import threading
import docx2pdf
import time

def convert_to_pdf():
    # Mendapatkan daftar file Word
    file_paths = filedialog.askopenfilenames(filetypes=[("Word Documents", "*.docx")])

    if len(file_paths) == 0:
        return

    # Memilih folder tujuan untuk file PDF
    output_folder = filedialog.askdirectory()
    if not output_folder:
        return

    # Memulai thread untuk menjalankan konversi ke PDF
    thread = threading.Thread(target=convert_files, args=(file_paths, output_folder))
    thread.start()

def convert_files(file_paths, output_folder):
    try:
        total_files = len(file_paths)
        progress_value = 0

        progress_window = tk.Toplevel(root)
        progress_window.title("Proses Konversi")
        progress_window.geometry("300x100")

        progress_label = tk.Label(progress_window, text="Konversi sedang berlangsung...", font=("Poppins", 12))
        progress_label.pack(pady=10)

        progress_bar = Progressbar(progress_window, length=250, mode="determinate")
        progress_bar.pack(pady=10)

        for file_path in file_paths:
            # Membuat thread untuk setiap file Word
            thread = threading.Thread(target=convert_file, args=(file_path, output_folder))
            thread.start()

            thread.join()
            progress_value += 1
            progress_bar["value"] = (progress_value / total_files) * 100
            progress_window.update()

            # Menambahkan penundaan selama 1 detik untuk efek thread
            time.sleep(1)

        # Menampilkan pesan berhasil dalam kotak dialog
        messagebox.showinfo("Konversi Berhasil", "File berhasil dikonversi ke PDF.")

        # Menampilkan folder tujuan dalam kotak dialog
        messagebox.showinfo("Folder Tujuan", f"File PDF disimpan di:\n{output_folder}")

        progress_window.destroy()
    except Exception as e:
        # Menampilkan pesan error dalam kotak dialog
        messagebox.showerror("Konversi Gagal", str(e))
        progress_window.destroy()

def convert_file(file_path, output_folder):
    try:
        # Mengonversi file Word ke PDF
        pdf_path = os.path.join(output_folder, os.path.basename(file_path) + ".pdf")
        docx2pdf.convert(file_path, pdf_path)
    except Exception as e:
        # Menampilkan pesan error dalam kotak dialog
        messagebox.showerror("Konversi Gagal", str(e))

# Membuat GUI dengan menggunakan Tkinter
root = tk.Tk()
root.title("Konversi Word ke PDF")
root.geometry("400x200")

# Membuat label judul
title_label = tk.Label(root, text="Konversi File Word ke PDF", font=("Poppins", 16), bg="#FFFFFF")
title_label.pack(pady=10)
subtitle_label = tk.Label(root, text="UAS P.Paralel Kelompok 7", font=("Poppins", 16), bg="#FFFFFF")
subtitle_label.pack(pady=10)

# Membuat tombol "Pilih File" untuk memilih file Word dan konversi ke PDF
select_button = tk.Button(root, text="Pilih File Word", font=("Arial", 12), command=convert_to_pdf, bg='#A2B38B')
select_button.pack(pady=20)

# Menjalankan mainloop GUI
root.mainloop()
