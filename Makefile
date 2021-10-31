all: build run

build:
	csc *.cs */*.cs */*/*.cs

run:
	mono Main.exe

dotnet:
	dotnet build