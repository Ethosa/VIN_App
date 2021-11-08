import pypyodbc as pydb
import os


cnct = pydb.connect("Driver={SQL Server Native Client 11.0};"
                    "Server=db-aws.rndn.ga;"
                    "Database=gibdd;"
                    "uid=renardein;pwd=aFTMSwScdmARmycH;")

cursor = cnct.cursor()


# for i, filename in enumerate(os.listdir("../docs/Ресурсы/Сессия 2/drivers 2/photo")):
# 	print(i+1, filename)
# 	path = f"D:/Ethosa/vinapp/vin_app/docs/Ресурсы/Сессия 2/drivers 2/photo/{filename}"
# 	with open(path, 'rb') as f:
# 		data = f.read()
# 	cursor.execute(
# 		"INSERT INTO driverPhoto (filename, image_data) VALUES (?, ?)", (filename,data))
# 	cursor.commit()

print(cursor.execute("""SELECT TOP (1000) [pid]
      ,[filename]
      ,[image_data]
  FROM [gibdd].[dbo].[driverPhoto]""").fetchall())

cursor.close()
cnct.close()
