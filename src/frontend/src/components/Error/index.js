import React from 'react';

const Error = ({ platformCss, platformName, statusCode, status, error }) => {
  return (
    <>
      <header>{/* Add header component here */}</header>
      
      <div className={platformCss ? platformCss : ''}>
        <span className="platform-flag">
          {platformName}
        </span>
      </div>
      
      <main role="main">
        <div className="py-5">
          <div className="container bg-light py-3 px-lg-5 py-lg-5">
            <h1>Uh, oh!</h1>
            <p>Something has failed. Below are some details for debugging.</p>

            <p><strong>HTTP Status:</strong> {statusCode} {status}</p>
            <pre className="border border-danger p-3" style={{ whiteSpace: 'pre-wrap', wordBreak: 'keep-all' }}>
              {error}
            </pre>
          </div>
        </div>
      </main>

      <footer>{/* Add footer component here */}</footer>
    </>
  );
};

export default Error;
