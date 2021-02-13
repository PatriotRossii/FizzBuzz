fizz :: Int -> String
fizz x
    | mod x 15 == 0 = "FizzBuzz"
    | mod x 3 == 0 = "Fizz"
    | mod x 5 == 0 = "Buzz"
    | otherwise = show x

main = mapM_ (putStrLn) (map fizz [0..100])