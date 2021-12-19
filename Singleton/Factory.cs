interface Product{
	double getPrice();
	
}

class Groceries: Product{
	private double price;
	
	public Groceries(double price){
		this.price = price;
	}
	
	public double getPrice(){
		return this.price;
	}
}

