import polars as pl
import pyodbc
from sqlalchemy import create_engine

path = "MOCK_DATA_PRODUCTS.csv"
df = pl.read_csv(path)

server = 'localhost'
database = 'ProductsAPIDB'
username = 'sa'
password = 'Password_123'

connection_string = f'mssql+pyodbc://{username}:{password}@{server}/{database}?driver=ODBC+Driver+17+for+SQL+Server'
engine = create_engine(connection_string)

df_pandas = df.to_pandas()

df_pandas.to_sql('Product', engine, if_exists='append', index=False)

print("Data inserted successfully!")