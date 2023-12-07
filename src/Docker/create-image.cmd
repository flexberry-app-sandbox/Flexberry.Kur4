docker build --no-cache -f SQL\Dockerfile.PostgreSql -t kur4/postgre-sql ../SQL

docker build --no-cache -f Dockerfile -t kur4/app ../..
