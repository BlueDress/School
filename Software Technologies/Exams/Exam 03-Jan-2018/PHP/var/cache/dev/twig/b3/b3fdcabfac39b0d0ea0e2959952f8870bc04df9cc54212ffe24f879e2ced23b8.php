<?php

/* @Twig/layout.html.twig */
class __TwigTemplate_0ef46ff3e00be850b375145c4de69a72941605b1b30816a42d1a36aa92bc080f extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'head' => array($this, 'block_head'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_364396787c01e10126f64d3bdc103f040f454a0d6e1bfadd6533fa01211f45ad = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_364396787c01e10126f64d3bdc103f040f454a0d6e1bfadd6533fa01211f45ad->enter($__internal_364396787c01e10126f64d3bdc103f040f454a0d6e1bfadd6533fa01211f45ad_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/layout.html.twig"));

        $__internal_3dc4e1fa7dab23a37e258f1e6bc008d0f5444c4cc264a3c2764ef014026316f0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_3dc4e1fa7dab23a37e258f1e6bc008d0f5444c4cc264a3c2764ef014026316f0->enter($__internal_3dc4e1fa7dab23a37e258f1e6bc008d0f5444c4cc264a3c2764ef014026316f0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/layout.html.twig"));

        // line 1
        echo "<!DOCTYPE html>
<html>
    <head>
        <meta charset=\"";
        // line 4
        echo twig_escape_filter($this->env, $this->env->getCharset(), "html", null, true);
        echo "\" />
        <meta name=\"robots\" content=\"noindex,nofollow\" />
        <meta name=\"viewport\" content=\"width=device-width,initial-scale=1\" />
        <title>";
        // line 7
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
        <link rel=\"icon\" type=\"image/png\" href=\"";
        // line 8
        echo twig_include($this->env, $context, "@Twig/images/favicon.png.base64");
        echo "\">
        <style>";
        // line 9
        echo twig_include($this->env, $context, "@Twig/exception.css.twig");
        echo "</style>
        ";
        // line 10
        $this->displayBlock('head', $context, $blocks);
        // line 11
        echo "    </head>
    <body>
        <header>
            <div class=\"container\">
                <h1 class=\"logo\">";
        // line 15
        echo twig_include($this->env, $context, "@Twig/images/symfony-logo.svg");
        echo " Symfony Exception</h1>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/doc\">
                        <span class=\"icon\">";
        // line 19
        echo twig_include($this->env, $context, "@Twig/images/icon-book.svg");
        echo "</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Docs
                    </a>
                </div>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/support\">
                        <span class=\"icon\">";
        // line 26
        echo twig_include($this->env, $context, "@Twig/images/icon-support.svg");
        echo "</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Support
                    </a>
                </div>
            </div>
        </header>

        ";
        // line 33
        $this->displayBlock('body', $context, $blocks);
        // line 34
        echo "        ";
        echo twig_include($this->env, $context, "@Twig/base_js.html.twig");
        echo "
    </body>
</html>
";
        
        $__internal_364396787c01e10126f64d3bdc103f040f454a0d6e1bfadd6533fa01211f45ad->leave($__internal_364396787c01e10126f64d3bdc103f040f454a0d6e1bfadd6533fa01211f45ad_prof);

        
        $__internal_3dc4e1fa7dab23a37e258f1e6bc008d0f5444c4cc264a3c2764ef014026316f0->leave($__internal_3dc4e1fa7dab23a37e258f1e6bc008d0f5444c4cc264a3c2764ef014026316f0_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_19e15a62c11acb15dc07bf8c36c74072b2bcfb342481bb2078cfc74e36828692 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_19e15a62c11acb15dc07bf8c36c74072b2bcfb342481bb2078cfc74e36828692->enter($__internal_19e15a62c11acb15dc07bf8c36c74072b2bcfb342481bb2078cfc74e36828692_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_96a3bb7bf4e4339c7ffdf5e2e998e47c5e6c3a2d4f85caffe1a7046cbeabaa5f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_96a3bb7bf4e4339c7ffdf5e2e998e47c5e6c3a2d4f85caffe1a7046cbeabaa5f->enter($__internal_96a3bb7bf4e4339c7ffdf5e2e998e47c5e6c3a2d4f85caffe1a7046cbeabaa5f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        
        $__internal_96a3bb7bf4e4339c7ffdf5e2e998e47c5e6c3a2d4f85caffe1a7046cbeabaa5f->leave($__internal_96a3bb7bf4e4339c7ffdf5e2e998e47c5e6c3a2d4f85caffe1a7046cbeabaa5f_prof);

        
        $__internal_19e15a62c11acb15dc07bf8c36c74072b2bcfb342481bb2078cfc74e36828692->leave($__internal_19e15a62c11acb15dc07bf8c36c74072b2bcfb342481bb2078cfc74e36828692_prof);

    }

    // line 10
    public function block_head($context, array $blocks = array())
    {
        $__internal_2120fbccdfb51ab08bfa6153c897fd0b922df9d170e5ea7cea1e2883b8e2b91d = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_2120fbccdfb51ab08bfa6153c897fd0b922df9d170e5ea7cea1e2883b8e2b91d->enter($__internal_2120fbccdfb51ab08bfa6153c897fd0b922df9d170e5ea7cea1e2883b8e2b91d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_b477df35b48ea820b25e31764df36c69876aab91987933fb7fbcd7737485706d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b477df35b48ea820b25e31764df36c69876aab91987933fb7fbcd7737485706d->enter($__internal_b477df35b48ea820b25e31764df36c69876aab91987933fb7fbcd7737485706d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        
        $__internal_b477df35b48ea820b25e31764df36c69876aab91987933fb7fbcd7737485706d->leave($__internal_b477df35b48ea820b25e31764df36c69876aab91987933fb7fbcd7737485706d_prof);

        
        $__internal_2120fbccdfb51ab08bfa6153c897fd0b922df9d170e5ea7cea1e2883b8e2b91d->leave($__internal_2120fbccdfb51ab08bfa6153c897fd0b922df9d170e5ea7cea1e2883b8e2b91d_prof);

    }

    // line 33
    public function block_body($context, array $blocks = array())
    {
        $__internal_e18ef390a166e7ee3a45d0ecf68b55d6dd20d3063c94bdfdb1ab0ad02586cd21 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_e18ef390a166e7ee3a45d0ecf68b55d6dd20d3063c94bdfdb1ab0ad02586cd21->enter($__internal_e18ef390a166e7ee3a45d0ecf68b55d6dd20d3063c94bdfdb1ab0ad02586cd21_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_eb8ef37b6cee1adc9f86fe7603175803d904834157ec2e409189a780b3ca7415 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_eb8ef37b6cee1adc9f86fe7603175803d904834157ec2e409189a780b3ca7415->enter($__internal_eb8ef37b6cee1adc9f86fe7603175803d904834157ec2e409189a780b3ca7415_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        
        $__internal_eb8ef37b6cee1adc9f86fe7603175803d904834157ec2e409189a780b3ca7415->leave($__internal_eb8ef37b6cee1adc9f86fe7603175803d904834157ec2e409189a780b3ca7415_prof);

        
        $__internal_e18ef390a166e7ee3a45d0ecf68b55d6dd20d3063c94bdfdb1ab0ad02586cd21->leave($__internal_e18ef390a166e7ee3a45d0ecf68b55d6dd20d3063c94bdfdb1ab0ad02586cd21_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/layout.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  137 => 33,  120 => 10,  103 => 7,  88 => 34,  86 => 33,  76 => 26,  66 => 19,  59 => 15,  53 => 11,  51 => 10,  47 => 9,  43 => 8,  39 => 7,  33 => 4,  28 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("<!DOCTYPE html>
<html>
    <head>
        <meta charset=\"{{ _charset }}\" />
        <meta name=\"robots\" content=\"noindex,nofollow\" />
        <meta name=\"viewport\" content=\"width=device-width,initial-scale=1\" />
        <title>{% block title %}{% endblock %}</title>
        <link rel=\"icon\" type=\"image/png\" href=\"{{ include('@Twig/images/favicon.png.base64') }}\">
        <style>{{ include('@Twig/exception.css.twig') }}</style>
        {% block head %}{% endblock %}
    </head>
    <body>
        <header>
            <div class=\"container\">
                <h1 class=\"logo\">{{ include('@Twig/images/symfony-logo.svg') }} Symfony Exception</h1>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/doc\">
                        <span class=\"icon\">{{ include('@Twig/images/icon-book.svg') }}</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Docs
                    </a>
                </div>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/support\">
                        <span class=\"icon\">{{ include('@Twig/images/icon-support.svg') }}</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Support
                    </a>
                </div>
            </div>
        </header>

        {% block body %}{% endblock %}
        {{ include('@Twig/base_js.html.twig') }}
    </body>
</html>
", "@Twig/layout.html.twig", "C:\\Exam 03-Jan-2018\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\TwigBundle\\Resources\\views\\layout.html.twig");
    }
}
