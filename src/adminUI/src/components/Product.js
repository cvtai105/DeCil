import React from 'react';

const ProductCard = ({ image, name, price, rating, orderCount }) => {
  return (
    <div className="product-card">
      <img src={image} alt={name} />
      <h3>{name}</h3>
      <p>Price: ${price}</p>
      <p>Rating: {rating}</p>
      <p>Order Count: {orderCount}</p>
    </div>
  );
};

export default ProductCard;