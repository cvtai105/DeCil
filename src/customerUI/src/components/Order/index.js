import React from 'react';

const OrderComplete = ({
  platformCss,
  platformName,
  order,
  totalPaid,
  recommendations
}) => {
  return (
    <>
      <header>
        <div className={platformCss}>
          <span className="platform-flag">
            {platformName}
          </span>
        </div>
      </header>
      <main role="main" className="order">

        <section className="container order-complete-section">
          <div className="row">
            <div className="col-12 text-center">
              <h3>Your order is complete!</h3>
            </div>
            <div className="col-12 text-center">
              <p>We've sent you a confirmation email.</p>
            </div>
          </div>
          <div className="row border-bottom-solid padding-y-24">
            <div className="col-6 pl-md-0">
              Confirmation #
            </div>
            <div className="col-6 pr-md-0 text-right">
              {order.OrderId}
            </div>
          </div>
          <div className="row border-bottom-solid padding-y-24">
            <div className="col-6 pl-md-0">
              Tracking #
            </div>
            <div className="col-6 pr-md-0 text-right">
              {order.ShippingTrackingId}
            </div>
          </div>
          <div className="row padding-y-24">
            <div className="col-6 pl-md-0">
              Total Paid
            </div>
            <div className="col-6 pr-md-0 text-right">
              {renderMoney(totalPaid)}
            </div>
          </div>
          <div className="row">
            <div className="col-12 text-center">
              <a className="cymbal-button-primary" href="/" role="button">
                Continue Shopping
              </a>
            </div>
          </div>
        </section>

        {recommendations && (
          <>
            {/* Insert recommendations template/component here */}
          </>
        )}

      </main>

      <footer>
        {/* Insert footer component here */}
      </footer>
    </>
  );
};

export default OrderComplete;
