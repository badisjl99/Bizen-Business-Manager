import mysql.connector
import requests
from bs4 import BeautifulSoup

def clear_table(table_name):
    # Connect to the MySQL database
    db_connection = mysql.connector.connect(
        host='localhost',
        user='root',
        password='',
        database='app_db'
    )
    db_cursor = db_connection.cursor()

    # Execute the query to delete all records from the table
    delete_query = f"DELETE FROM {table_name}"
    db_cursor.execute(delete_query)
    db_connection.commit()

    # Close the database connection
    db_cursor.close()
    db_connection.close()

def insert_data_to_database(url, table_name):
    # Send a request to the webpage
    response = requests.get(url)
    soup = BeautifulSoup(response.content, 'html.parser')

    # Find titles, prices, and promotions
    titles = soup.find_all("a", class_="goods-title")
    prices = soup.find_all("span", class_="goods-price-value")
    promos = soup.find_all("div", class_="tag-text")

    # Clear the table before refilling it with new data
    clear_table(table_name)

    # Connect to the MySQL database
    db_connection = mysql.connector.connect(
        host='localhost',
        user='root',
        password='',
        database='app_db'
    )
    db_cursor = db_connection.cursor()

    for title, price, promo in zip(titles, prices, promos):
        # Extract text from tags
        title_text = title.text.strip()
        price_text = price.text.strip()
        promo_text = promo.text.strip()

        # Write stats to MySQL database
        item_name = title_text
        item_price = price_text
        item_discount = promo_text

        # Assuming you have a table named 'scrapdata' with columns 'item_name', 'item_price', and 'item_discount'
        insert_query = "INSERT INTO scrapdata (item_name, item_price, item_discount,) VALUES (%s, %s, %s)"
        db_cursor.execute(insert_query, (item_name, item_price, item_discount))
        db_connection.commit()

    # Close the database connection
    db_cursor.close()
    db_connection.close()

    print("Data Inserted Successfully !")

if __name__ == "__main__":
    webpage_url = 'https://www.newegg.com/d/Best-Sellers/Games/s/ID-1562 '

    # Replace 'scrapdata' with the name of the table you want to clear and refill with new data
    table_name = 'scrapdata'

    insert_data_to_database(webpage_url, table_name)
