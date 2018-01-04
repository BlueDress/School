<?php

/* @WebProfiler/Collector/exception.html.twig */
class __TwigTemplate_f32ad73c9bc804e7d7685ce925e27ce9c7daa98efc0b9a8c89227d7076a75563 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/exception.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_5934975e4d839f2acd7e53c6aca8f90f71ec9f703fedb600804aeee1d9fd8527 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_5934975e4d839f2acd7e53c6aca8f90f71ec9f703fedb600804aeee1d9fd8527->enter($__internal_5934975e4d839f2acd7e53c6aca8f90f71ec9f703fedb600804aeee1d9fd8527_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $__internal_7bd68b822bf1f367fdfed1561d391b1223fdbe6d3c9d6f2a1e19d02e83bf3cab = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_7bd68b822bf1f367fdfed1561d391b1223fdbe6d3c9d6f2a1e19d02e83bf3cab->enter($__internal_7bd68b822bf1f367fdfed1561d391b1223fdbe6d3c9d6f2a1e19d02e83bf3cab_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_5934975e4d839f2acd7e53c6aca8f90f71ec9f703fedb600804aeee1d9fd8527->leave($__internal_5934975e4d839f2acd7e53c6aca8f90f71ec9f703fedb600804aeee1d9fd8527_prof);

        
        $__internal_7bd68b822bf1f367fdfed1561d391b1223fdbe6d3c9d6f2a1e19d02e83bf3cab->leave($__internal_7bd68b822bf1f367fdfed1561d391b1223fdbe6d3c9d6f2a1e19d02e83bf3cab_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_55b403b0ac87e064dcc01f545db7940be7637193646ae7bdf96da3b57d6d56ed = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_55b403b0ac87e064dcc01f545db7940be7637193646ae7bdf96da3b57d6d56ed->enter($__internal_55b403b0ac87e064dcc01f545db7940be7637193646ae7bdf96da3b57d6d56ed_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_e9aa374ff956b605eb04c7d6f4225c1405d6fbea186497fb0d730d9b5b7f2ac1 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e9aa374ff956b605eb04c7d6f4225c1405d6fbea186497fb0d730d9b5b7f2ac1->enter($__internal_e9aa374ff956b605eb04c7d6f4225c1405d6fbea186497fb0d730d9b5b7f2ac1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    ";
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 5
            echo "        <style>
            ";
            // line 6
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception_css", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </style>
    ";
        }
        // line 9
        echo "    ";
        $this->displayParentBlock("head", $context, $blocks);
        echo "
";
        
        $__internal_e9aa374ff956b605eb04c7d6f4225c1405d6fbea186497fb0d730d9b5b7f2ac1->leave($__internal_e9aa374ff956b605eb04c7d6f4225c1405d6fbea186497fb0d730d9b5b7f2ac1_prof);

        
        $__internal_55b403b0ac87e064dcc01f545db7940be7637193646ae7bdf96da3b57d6d56ed->leave($__internal_55b403b0ac87e064dcc01f545db7940be7637193646ae7bdf96da3b57d6d56ed_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_58282a5d13cefc1c2e7d4bc781967ffb70b4b244fffad7c18ebba342997c5af0 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_58282a5d13cefc1c2e7d4bc781967ffb70b4b244fffad7c18ebba342997c5af0->enter($__internal_58282a5d13cefc1c2e7d4bc781967ffb70b4b244fffad7c18ebba342997c5af0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_3eb4286a88bf569fbb37869ced666518756ca83abc6fc1848837645bc4b6d955 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_3eb4286a88bf569fbb37869ced666518756ca83abc6fc1848837645bc4b6d955->enter($__internal_3eb4286a88bf569fbb37869ced666518756ca83abc6fc1848837645bc4b6d955_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 13
        echo "    <span class=\"label ";
        echo (($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) ? ("label-status-error") : ("disabled"));
        echo "\">
        <span class=\"icon\">";
        // line 14
        echo twig_include($this->env, $context, "@WebProfiler/Icon/exception.svg");
        echo "</span>
        <strong>Exception</strong>
        ";
        // line 16
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 17
            echo "            <span class=\"count\">
                <span>1</span>
            </span>
        ";
        }
        // line 21
        echo "    </span>
";
        
        $__internal_3eb4286a88bf569fbb37869ced666518756ca83abc6fc1848837645bc4b6d955->leave($__internal_3eb4286a88bf569fbb37869ced666518756ca83abc6fc1848837645bc4b6d955_prof);

        
        $__internal_58282a5d13cefc1c2e7d4bc781967ffb70b4b244fffad7c18ebba342997c5af0->leave($__internal_58282a5d13cefc1c2e7d4bc781967ffb70b4b244fffad7c18ebba342997c5af0_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_cec599eebc89527d58d46cfb359537ae562fdd27949a27be4990801f6c81b8b4 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_cec599eebc89527d58d46cfb359537ae562fdd27949a27be4990801f6c81b8b4->enter($__internal_cec599eebc89527d58d46cfb359537ae562fdd27949a27be4990801f6c81b8b4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_3c86eb2aa659e6cbdf4f7eaaa257f7e866777e211a8c097088a5d3d252235fdc = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_3c86eb2aa659e6cbdf4f7eaaa257f7e866777e211a8c097088a5d3d252235fdc->enter($__internal_3c86eb2aa659e6cbdf4f7eaaa257f7e866777e211a8c097088a5d3d252235fdc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 25
        echo "    <h2>Exceptions</h2>

    ";
        // line 27
        if ( !$this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 28
            echo "        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    ";
        } else {
            // line 32
            echo "        <div class=\"sf-reset\">
            ";
            // line 33
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </div>
    ";
        }
        
        $__internal_3c86eb2aa659e6cbdf4f7eaaa257f7e866777e211a8c097088a5d3d252235fdc->leave($__internal_3c86eb2aa659e6cbdf4f7eaaa257f7e866777e211a8c097088a5d3d252235fdc_prof);

        
        $__internal_cec599eebc89527d58d46cfb359537ae562fdd27949a27be4990801f6c81b8b4->leave($__internal_cec599eebc89527d58d46cfb359537ae562fdd27949a27be4990801f6c81b8b4_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/exception.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  138 => 33,  135 => 32,  129 => 28,  127 => 27,  123 => 25,  114 => 24,  103 => 21,  97 => 17,  95 => 16,  90 => 14,  85 => 13,  76 => 12,  63 => 9,  57 => 6,  54 => 5,  51 => 4,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block head %}
    {% if collector.hasexception %}
        <style>
            {{ render(path('_profiler_exception_css', { token: token })) }}
        </style>
    {% endif %}
    {{ parent() }}
{% endblock %}

{% block menu %}
    <span class=\"label {{ collector.hasexception ? 'label-status-error' : 'disabled' }}\">
        <span class=\"icon\">{{ include('@WebProfiler/Icon/exception.svg') }}</span>
        <strong>Exception</strong>
        {% if collector.hasexception %}
            <span class=\"count\">
                <span>1</span>
            </span>
        {% endif %}
    </span>
{% endblock %}

{% block panel %}
    <h2>Exceptions</h2>

    {% if not collector.hasexception %}
        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    {% else %}
        <div class=\"sf-reset\">
            {{ render(path('_profiler_exception', { token: token })) }}
        </div>
    {% endif %}
{% endblock %}
", "@WebProfiler/Collector/exception.html.twig", "C:\\Exam 03-Jan-2018\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\exception.html.twig");
    }
}
