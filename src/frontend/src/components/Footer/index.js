import React from 'react';

const Footer = ({ currentYear, sessionId, requestId, deploymentDetails }) => {
  return (
    <footer className="py-5">
      <div className="footer-top">
        <div className="container footer-social">
          <p className="footer-text">
            This website is hosted for demo purposes only. It is not an actual shop. This is not a Google product.
          </p>
          <p className="footer-text">
            © 2020-{currentYear} Google LLC (<a href="https://github.com/GoogleCloudPlatform/microservices-demo">Source Code</a>)
          </p>
          <p className="footer-text">
            <small>
              {sessionId ? `session-id: ${sessionId} — ` : ''}
              {requestId ? `request-id: ${requestId}` : ''}
            </small>
            <br />
            <small>
              {deploymentDetails ? (
                <>
                  {deploymentDetails.CLUSTERNAME && <b>Cluster: {deploymentDetails.CLUSTERNAME}</b>}<br />
                  {deploymentDetails.ZONE && <b>Zone: {deploymentDetails.ZONE}</b>}<br />
                  {deploymentDetails.HOSTNAME && <b>Pod: {deploymentDetails.HOSTNAME}</b>}
                </>
              ) : (
                'Deployment details are still loading. Try refreshing this page.'
              )}
            </small>
          </p>
        </div>
      </div>
      <script
        src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"
        integrity="sha384-smHYKdLADwkXOn1EmN1qk/HfnUcbVRZyYmZ4qpPea6sjB/pTJ0euyQp0Mk8ck+5T"
        crossOrigin="anonymous"
      ></script>
    </footer>
  );
};

export default Footer;
