import React from 'react';

const Recommendations = ({ recommendations }) => {
  return (
    <section className="recommendations">
      <div className="container">
        <div className="row">
          <div className="col-xl-10 offset-xl-1">
            <h2>You May Also Like</h2>
            <div className="row">
              {recommendations.map(item => (
                <div key={item.Id} className="col-md-3">
                  <div>
                    <a href={`/product/${item.Id}`}>
                      <img alt="" src={item.Picture} />
                    </a>
                    <div>
                      <h5>{item.Name}</h5>
                    </div>
                  </div>
                </div>
              ))}
            </div>
          </div>
        </div>
      </div>
    </section>
  );
};

export default Recommendations;
