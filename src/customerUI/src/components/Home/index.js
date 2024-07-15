import React from 'react';

const Home = ({
  platformCss,
  platformName,
  products
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
      <main role="main" className="home">

        {/* The image at the top of the home page, displayed on smaller screens. */}
        <div className="home-mobile-hero-banner d-lg-none"></div>

        <div className="container-fluid">
          <div className="row">

            {/* The image on the left of the home page, displayed on larger screens. */}
            {/* <div className="col-4 d-none d-lg-block home-desktop-left-image"></div> */}
            {/* @TODO: removed temporarily. When uncommenting, also replace below div with this */}
            {/* <div className="col-12 col-lg-8"> */}

            <div className="col-12 col-lg-12 px-10-percent">

              <div className="row hot-products-row px-xl-6">

                <div className="col-12">
                  <h3>Hot Products</h3>
                </div>

                {products.map(product => (
                  <div key={product.Item.Id} className="col-md-4 hot-product-card">
                    <a href={`/product/${product.Item.Id}`}>
                      <img loading="lazy" src={product.Item.Picture} alt={product.Item.Name} />
                      <div className="hot-product-card-img-overlay"></div>
                    </a>
                    <div>
                      <div className="hot-product-card-name">{product.Item.Name}</div>
                      <div className="hot-product-card-price">{renderMoney(product.Price)}</div>
                    </div>
                  </div>
                ))}

              </div>

              {/* Footer for larger screens. */}
              <div className="row d-none d-lg-block home-desktop-footer-row">
                <div className="col-12 p-0">
                  <footer>
                    {/* Insert footer component here */}
                  </footer>
                </div>
              </div>

            </div>

          </div>
        </div>

      </main>

      {/* Footer for smaller screens. */}
      <div className="d-lg-none">
        <footer>
          {/* Insert footer component here */}
        </footer>
      </div>
    </>
  );
};

export default Home;
