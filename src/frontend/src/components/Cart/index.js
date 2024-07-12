import React from 'react';

const Cart = ({ platformCss, platformName, items, cartSize, shippingCost, totalCost, expirationYears, recommendations }) => {
  return (
    <>
      <header>{/* Add header component here */}</header>
      
      <div className={platformCss ? platformCss : ''}>
        <span className="platform-flag">
          {platformName}
        </span>
      </div>
      
      <main role="main" className="cart-sections">
        {items.length === 0 ? (
          <section className="empty-cart-section">
            <h3>Your shopping cart is empty!</h3>
            <p>Items you add to your shopping cart will appear here.</p>
            <a className="cymbal-button-primary" href="/" role="button">Continue Shopping</a>
          </section>
        ) : (
          <section className="container">
            <div className="row">
              <div className="col-lg-6 col-xl-5 offset-xl-1 cart-summary-section">
                <div className="row mb-3 py-2">
                  <div className="col-4 pl-md-0">
                    <h3>Cart ({cartSize})</h3>
                  </div>
                  <div className="col-8 pr-md-0 text-right">
                    <form method="POST" action="/cart/empty">
                      <button className="cymbal-button-secondary cart-summary-empty-cart-button" type="submit">
                        Empty Cart
                      </button>
                      <a className="cymbal-button-primary" href="/" role="button">
                        Continue Shopping
                      </a>
                    </form>
                  </div>
                </div>

                {items.map((item, index) => (
                  <div className="row cart-summary-item-row" key={index}>
                    <div className="col-md-4 pl-md-0">
                      <a href={`/product/${item.Item.Id}`}>
                        <img className="img-fluid" alt="" src={item.Item.Picture} />
                      </a>
                    </div>
                    <div className="col-md-8 pr-md-0">
                      <div className="row">
                        <div className="col">
                          <h4>{item.Item.Name}</h4>
                        </div>
                      </div>
                      <div className="row cart-summary-item-row-item-id-row">
                        <div className="col">
                          SKU #{item.Item.Id}
                        </div>
                      </div>
                      <div className="row">
                        <div className="col">
                          Quantity: {item.Quantity}
                        </div>
                        <div className="col pr-md-0 text-right">
                          <strong>
                            {item.Price}
                          </strong>
                        </div>
                      </div>
                    </div>
                  </div>
                ))}

                <div className="row cart-summary-shipping-row">
                  <div className="col pl-md-0">Shipping</div>
                  <div className="col pr-md-0 text-right">{shippingCost}</div>
                </div>

                <div className="row cart-summary-total-row">
                  <div className="col pl-md-0">Total</div>
                  <div className="col pr-md-0 text-right">{totalCost}</div>
                </div>
              </div>

              <div className="col-lg-5 offset-lg-1 col-xl-4">
                <form className="cart-checkout-form" action="/cart/checkout" method="POST">
                  <div className="row">
                    <div className="col">
                      <h3>Shipping Address</h3>
                    </div>
                  </div>

                  <div className="form-row">
                    <div className="col cymbal-form-field">
                      <label htmlFor="email">E-mail Address</label>
                      <input type="email" id="email" name="email" defaultValue="someone@example.com" required />
                    </div>
                  </div>

                  <div className="form-row">
                    <div className="col cymbal-form-field">
                      <label htmlFor="street_address">Street Address</label>
                      <input type="text" name="street_address" id="street_address" defaultValue="1600 Amphitheatre Parkway" required />
                    </div>
                  </div>

                  <div className="form-row">
                    <div className="col cymbal-form-field">
                      <label htmlFor="zip_code">Zip Code</label>
                      <input type="text" name="zip_code" id="zip_code" defaultValue="94043" required pattern="\d{4,5}" />
                    </div>
                  </div>

                  <div className="form-row">
                    <div className="col cymbal-form-field">
                      <label htmlFor="city">City</label>
                      <input type="text" name="city" id="city" defaultValue="Mountain View" required />
                    </div>
                  </div>

                  <div className="form-row">
                    <div className="col-md-5 cymbal-form-field">
                      <label htmlFor="state">State</label>
                      <input type="text" name="state" id="state" defaultValue="CA" required />
                    </div>
                    <div className="col-md-7 cymbal-form-field">
                      <label htmlFor="country">Country</label>
                      <input type="text" id="country" placeholder="Country Name" name="country" defaultValue="United States" required />
                    </div>
                  </div>

                  <div className="row">
                    <div className="col">
                      <h3 className="payment-method-heading">Payment Method</h3>
                    </div>
                  </div>

                  <div className="form-row">
                    <div className="col cymbal-form-field">
                      <label htmlFor="credit_card_number">Credit Card Number</label>
                      <input type="text" id="credit_card_number" name="credit_card_number" placeholder="0000000000000000" defaultValue="4432801561520454" required pattern="\d{16}" />
                    </div>
                  </div>

                  <div className="form-row">
                    <div className="col-md-5 cymbal-form-field">
                      <label htmlFor="credit_card_expiration_month">Month</label>
                      <select name="credit_card_expiration_month" id="credit_card_expiration_month">
                        <option value="1">January</option>
                        <option value="2">February</option>
                        <option value="3">March</option>
                        <option value="4">April</option>
                        <option value="5">May</option>
                        <option value="6">June</option>
                        <option value="7">July</option>
                        <option value="8">August</option>
                        <option value="9">September</option>
                        <option value="10">October</option>
                        <option value="11">November</option>
                        <option value="12">December</option>
                      </select>
                      <img src="/static/icons/Hipster_DownArrow.svg" alt="" className="cymbal-dropdown-chevron" />
                    </div>
                    <div className="col-md-4 cymbal-form-field">
                      <label htmlFor="credit_card_expiration_year">Year</label>
                      <select name="credit_card_expiration_year" id="credit_card_expiration_year">
                        {expirationYears.map((year, index) => (
                          <option value={year} key={index} selected={index === 1}>
                            {year}
                          </option>
                        ))}
                      </select>
                      <img src="/static/icons/Hipster_DownArrow.svg" alt="" className="cymbal-dropdown-chevron" />
                    </div>
                    <div className="col-md-3 cymbal-form-field">
                      <label htmlFor="credit_card_cvv">CVV</label>
                      <input type="password" id="credit_card_cvv" name="credit_card_cvv" defaultValue="672" required pattern="\d{3}" />
                    </div>
                  </div>

                  <div className="form-row justify-content-center">
                    <div className="col text-center">
                      <button className="cymbal-button-primary" type="submit">
                        Place Order
                      </button>
                    </div>
                  </div>
                </form>
              </div>
            </div>
          </section>
        )}
      </main>

      {recommendations && (
        <section>{/* Add recommendations component here */}</section>
      )}

      <footer>{/* Add footer component here */}</footer>
    </>
  );
};

export default Cart;
