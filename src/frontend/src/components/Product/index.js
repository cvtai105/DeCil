import React from 'react';

const ProductDetail = ({
  platformCss,
  platformName,
  product,
  packagingInfo,
  recommendations,
  ad
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

      <main role="main">
        <div className="h-product container">
          <div className="row">
            <div className="col-md-6">
              <img className="product-image" alt="" src={product.Item.Picture} />
            </div>
            <div className="product-info col-md-5">
              <div className="product-wrapper">
                <h2>{product.Item.Name}</h2>
                <p className="product-price">{renderMoney(product.Price)}</p>
                <p>{product.Item.Description}</p>

                {packagingInfo && (
                  <div className="product-packaging">
                    <h3>Packaging</h3>
                    <span>Weight: {packagingInfo.Weight ? `${packagingInfo.Weight}lb` : 'n/a'}</span>
                    <span>Width: {packagingInfo.Width ? `${packagingInfo.Width}cm` : 'n/a'}</span>
                    <span>Height: {packagingInfo.Height ? `${packagingInfo.Height}cm` : 'n/a'}</span>
                    <span>Depth: {packagingInfo.Depth ? `${packagingInfo.Depth}cm` : 'n/a'}</span>
                  </div>
                )}

                <form method="POST" action="/cart">
                  <input type="hidden" name="product_id" value={product.Item.Id} />
                  <div className="product-quantity-dropdown">
                    <select name="quantity" id="quantity">
                      {[1, 2, 3, 4, 5, 10].map(option => (
                        <option key={option}>{option}</option>
                      ))}
                    </select>
                    <img src="/static/icons/Hipster_DownArrow.svg" alt="" />
                  </div>
                  <button type="submit" className="cymbal-button-primary">
                    Add To Cart
                  </button>
                </form>
              </div>
            </div>
          </div>
        </div>

        {recommendations && (
          <>
            {/* Insert recommendations template/component here */}
          </>
        )}

        <div className="ad">
          {ad && (
            <>
              {/* Insert ad template/component here */}
            </>
          )}
        </div>
      </main>

      <footer>
        {/* Insert footer component here */}
      </footer>
    </>
  );
};

export default ProductDetail;
