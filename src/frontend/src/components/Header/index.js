import React from 'react';

const Header = ({
  isCymbalBrand,
  frontendMessage,
  showCurrency,
  userCurrency,
  currencies,
  assistantEnabled,
  cartSize
}) => {
  return (
    <>
      <head>
        <meta charSet="UTF-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no" />
        <meta httpEquiv="X-UA-Compatible" content="ie=edge" />
        <title>{isCymbalBrand ? 'Cymbal Shops' : 'Online Boutique'}</title>
        <link
          href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"
          rel="stylesheet"
          integrity="sha384-WskhaSGFgHYWDcbwN70/dfYBj47jz9qbsMId/iRN3ewGhXQFZCSftd1LZCfmhktB"
          crossOrigin="anonymous"
        />
        <link rel="preconnect" href="https://fonts.googleapis.com" />
        <link rel="preconnect" href="https://fonts.gstatic.com" crossOrigin="true" />
        <link
          href="https://fonts.googleapis.com/css2?family=DM+Sans:ital,wght@0,400;0,700;1,400;1,700&display=swap"
          rel="stylesheet"
        />
        <link
          href="https://fonts.googleapis.com/css2?family=Google+Symbols:opsz,wght,FILL,GRAD@20..48,100..700,0..1,-50..200"
          rel="stylesheet"
        />
        <link rel="stylesheet" type="text/css" href="/static/styles/styles.css" />
        <link rel="stylesheet" type="text/css" href="/static/styles/cart.css" />
        <link rel="stylesheet" type="text/css" href="/static/styles/order.css" />
        <link rel="stylesheet" type="text/css" href="/static/styles/bot.css" />
        {isCymbalBrand ? (
          <link rel="shortcut icon" type="image/x-icon" href="/static/favicon-cymbal.ico" />
        ) : (
          <link rel="shortcut icon" type="image/x-icon" href="/static/favicon.ico" />
        )}
      </head>

      <body>
        <header>
          {frontendMessage && (
            <div className="navbar">
              <div className="container d-flex justify-content-center">
                <div className="h-free-shipping">{frontendMessage}</div>
              </div>
            </div>
          )}
          <div className="navbar sub-navbar">
            <div className="container d-flex justify-content-between">
              <a href="/" className="navbar-brand d-flex align-items-center">
                {isCymbalBrand ? (
                  <img src="/static/icons/Cymbal_NavLogo.svg" alt="" className="top-left-logo-cymbal" />
                ) : (
                  <img src="/static/icons/Hipster_NavLogo.svg" alt="" className="top-left-logo" />
                )}
              </a>
              <div className="controls">
                {showCurrency && (
                  <div className="h-controls">
                    <div className="h-control">
                      <span className="icon currency-icon">{/* Render currency logo here */}</span>
                      <form method="POST" className="controls-form" action="/setCurrency" id="currency_form">
                        <select
                          name="currency_code"
                          onChange={() => document.getElementById('currency_form').submit()}
                        >
                          {currencies.map(currency => (
                            <option key={currency} value={currency} selected={currency === userCurrency}>
                              {currency}
                            </option>
                          ))}
                        </select>
                      </form>
                      <img src="/static/icons/Hipster_DownArrow.svg" alt="" className="icon arrow" />
                    </div>
                  </div>
                )}

                {assistantEnabled && (
                  <a href="/assistant" className="cart-link">
                    <img
                      src="/static/icons/Hipster_WandIcon.svg"
                      style={{ width: '22px', height: '22px' }}
                      alt="Assistant icon"
                      className="logo"
                      title="Assistant"
                    />
                  </a>
                )}

                <a href="/cart" className="cart-link">
                  <img
                    src="/static/icons/Hipster_CartIcon.svg"
                    alt="Cart icon"
                    className="logo"
                    title="Cart"
                  />
                  {cartSize && <span className="cart-size-circle">{cartSize}</span>}
                </a>
              </div>
            </div>
          </div>
        </header>
      </body>
    </>
  );
};

export default Header;
