use std::io::Write;

fn main() {
    let stdin = std::io::stdin();
    
    print!("Введите границу: ");
    std::io::stdout().flush().expect("Failed to flush");

    let mut number = String::new();
    stdin.read_line(&mut number).expect("Failed to read a line");
    let number: i32 = number.trim().parse().expect("Failed to parse");

    for i in 1..=number {
        if i % 3 == 0 {
            print!("Fizz");
        }
        if i % 5 == 0 {
            print!("Buzz");
        }
        if (i % 5 != 0) && (i % 3 != 0) {
            print!("{}", i);
        }
        println!();
    }

}