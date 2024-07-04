import mysql.connector

from DatabaseConnection import YummyFoodRestaurantDB

class EmployeeAdapter(YummyFoodRestaurantDB):

    def __init__(self):
        super().__init__()



    #return array index 0:positionName, 1:staffName, 2:emailAddress
    def getEmployeeData(self, staffID, password):
        try:
            cursor = self.connection.cursor()
            query = "SELECT positionName, staffName, emailAddress FROM employee WHERE staffID = %s AND password = %s;"
            cursor.execute(query, (staffID, password))
            result = cursor.fetchone()
            cursor.close()
            return [data for data in result]
        except Exception as e:
            print(f"database query error: {e}")
            return None

    def getPositionPermission(self, positionName):
        try:
            cursor = self.connection.cursor()
            query = "SELECT functionName FROM permission WHERE positionName = %s;"
            cursor.execute(query, (positionName, ))
            result = cursor.fetchall()
            data = [permission[0] for permission in result]
            cursor.close()
        except Exception as e:
            print(e)
            return None
        return data
    
    def isFunctionAllowed(self, id, password, functionName):
        try:
            cursor = self.connection.cursor()
            query = "SELECT staffID FROM employee, permission WHERE staffID = %s AND password = %s AND employee.positionName = permission.positionName AND functionName = %s;"
            cursor.execute(query, (id, password, functionName))
            result = cursor.fetchone()
            print(result)
            cursor.close()
            if result != None:
                return True
            else:
                return False
        except Exception as e:
            print(f"database query error: {e}")
            return False
