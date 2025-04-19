using System;

class Item {
    public string code;
    public string name;
    public string expirationDate;
    public string manufacturer;
    public string createdDate;
    public Category category;

    public string toString() {
        string categoryString;
        if (category != null) {
            categoryString = category.toString();
        } else {
            categoryString = "no category";
        }
        return "Item " + code + ", name: " + name + ", expirationDate: " + expirationDate
        + ", manufacturer: " + manufacturer + ", createdDate: " + createdDate + ", and " + categoryString;
    }
}