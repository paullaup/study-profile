import mysql.connector
class YummyFoodRestaurantDB:

    def __init__(self):
        # Establish the connection
        try:
            self.connection = mysql.connector.connect(
                host='localhost',
                user='root',
                passwd='',
                db='yummy_food_restaurant'
            )
            print("Connected to MySQL database")
        except mysql.connector.Error as err:
            print("Error:", err)
