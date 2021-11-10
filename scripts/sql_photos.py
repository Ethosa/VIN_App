import pypyodbc as pydb
import os


cnct = pydb.connect("Driver={SQL Server Native Client 11.0};"
                    "Server=db-aws.rndn.ga;"
                    "Database=gibdd;"
                    "uid=renardein;pwd=aFTMSwScdmARmycH;")

cursor = cnct.cursor()




for i, filename in enumerate(os.listdir("../docs/Ресурсы/Сессия 2/drivers 2/photo")):
    print(i+1, filename)
    path = f"../docs/Ресурсы/Сессия 2/drivers 2/photo/{filename}"
    with open(path, 'rb') as f:
        data = f.read()
        imgdata = ''
        for i in data:
        	if i != 0:
        		imgdata += chr(i)
        	else:
        		imgdata += '000'
        print(imgdata)
    cursor.execute(
        "INSERT into driverPhoto (pid, filename, image_data) values (?, ?, ?)", (1, filename, imgdata))
    cursor.commit()
    break

# print(cursor.execute("""SELECT TOP (1000) [pid]
#       ,[filename]
#       ,[image_data]
#   FROM [gibdd].[dbo].[driverPhoto]""").fetchall())

# translate to png
# with open('img.png', 'wb') as ff:
#     ff.write(data.replace(b'\x99\x11', b'\x00'))

cursor.close()
cnct.close()
