function calculateMoneyForFruit(fruitType, weightInGrams, pricePerKilogram) {
    const weightInKilograms = weightInGrams / 1000;
    const totalPrice = weightInKilograms * pricePerKilogram;
    
    const roundedTotalPrice = totalPrice.toFixed(2);
    const roundedWeight = weightInKilograms.toFixed(2);
    
    console.log(`I need $${roundedTotalPrice} to buy ${roundedWeight} kilograms ${fruitType}.`);
}

