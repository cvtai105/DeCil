import React from 'react';

const Ad = ({ redirectUrl, text }) => {
  return (
    <div className="container py-3 px-lg-5 py-lg-5">
      <div role="alert">
        <strong>Ad</strong>
        <a href={redirectUrl} rel="nofollow noopener noreferrer" target="_blank">
          {text}
        </a>
      </div>
    </div>
  );
};

export default Ad;
