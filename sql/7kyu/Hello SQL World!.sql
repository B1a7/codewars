-- Hello SQL!

-- Return a table with a single column named Greeting with the phrase 'hello world!'

-- Please use Data Manipulation Language and not Data Definition Language to solve this Kata


CREATE TABLE helloWorld(Greeting varchar(255));
INSERT INTO helloWorld(Greeting)
    VALUES ('hello world!');
SELECT * FROM helloWorld;
